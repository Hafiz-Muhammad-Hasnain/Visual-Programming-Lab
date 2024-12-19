-- Use the newly created database
USE InventoryManagementSystem;
GO

-- Create the Products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    SKU NVARCHAR(50) UNIQUE NOT NULL,
    Category NVARCHAR(50) NULL,
    Quantity INT DEFAULT 0,
    UnitPrice DECIMAL(10, 2) NULL,
    Barcode NVARCHAR(50) NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);

-- Create the Suppliers table
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100) NULL,
    Phone NVARCHAR(15) NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL
);

-- Create the PurchaseOrders table
CREATE TABLE PurchaseOrders (
    PurchaseOrderID INT PRIMARY KEY IDENTITY(1,1),
    SupplierID INT FOREIGN KEY REFERENCES Suppliers(SupplierID),
    OrderDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) CHECK (Status IN ('Pending', 'Completed', 'Cancelled')),
    TotalAmount DECIMAL(10, 2) NULL
);

-- Create the PurchaseOrderDetails table
CREATE TABLE PurchaseOrderDetails (
    PODetailID INT PRIMARY KEY IDENTITY(1,1),
    PurchaseOrderID INT FOREIGN KEY REFERENCES PurchaseOrders(PurchaseOrderID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL
);

-- Create the SalesOrders table
CREATE TABLE SalesOrders (
    SalesOrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) CHECK (Status IN ('Pending', 'Shipped', 'Cancelled')),
    TotalAmount DECIMAL(10, 2) NULL
);

-- Create the SalesOrderDetails table
CREATE TABLE SalesOrderDetails (
    SODetailID INT PRIMARY KEY IDENTITY(1,1),
    SalesOrderID INT FOREIGN KEY REFERENCES SalesOrders(SalesOrderID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL
);

-- Create the StockMovements table
CREATE TABLE StockMovements (
    MovementID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    MovementType NVARCHAR(20) CHECK (MovementType IN ('IN', 'OUT', 'ADJUSTMENT')),
    Quantity INT NOT NULL,
    MovementDate DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(255) NULL
);

-- Create the Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) CHECK (Role IN ('Admin', 'Manager', 'Staff')),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Create the AuditLogs table
CREATE TABLE AuditLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Action NVARCHAR(100) NOT NULL,
    TableAffected NVARCHAR(50) NULL,
    ActionTime DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(255) NULL
);

-- Create the Categories table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) UNIQUE NOT NULL,
    Description NVARCHAR(255) NULL
);

-- Insert sample data into Categories
INSERT INTO Categories (CategoryName, Description) VALUES
('Electronics', 'Devices and gadgets'),
('Furniture', 'Home and office furniture'),
('Clothing', 'Apparel and accessories');

-- Insert sample data into Suppliers
INSERT INTO Suppliers (SupplierName, ContactName, Phone, Email, Address) VALUES
('Tech Supplies Co.', 'Alice Johnson', '123-456-7890', 'alice@techsupplies.com', '123 Tech Lane'),
('Furniture World', 'Bob Smith', '987-654-3210', 'bob@furnitureworld.com', '456 Furniture Ave');

-- Insert sample data into Products
INSERT INTO Products (Name, SKU, Category, Quantity, UnitPrice, Barcode) VALUES
('Laptop', 'SKU001', 'Electronics', 10, 999.99, '1234567890123'),
('Office Chair', 'SKU002', 'Furniture', 20, 149.99, '1234567890124'),
('T-Shirt', 'SKU003', 'Clothing', 50, 19.99, '1234567890125');

-- Insert sample data into PurchaseOrders
INSERT INTO PurchaseOrders (SupplierID, OrderDate, Status, TotalAmount) VALUES
(1, GETDATE(), 'Pending', 1999.98),
(2, GETDATE(), 'Completed', 1499.90);

-- Insert sample data into PurchaseOrderDetails
INSERT INTO PurchaseOrderDetails (PurchaseOrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 2, 999.99),  -- 2 Laptops
(2, 2, 10, 149.99); -- 10 Office Chairs

-- Insert sample data into SalesOrders
INSERT INTO SalesOrders (CustomerName, OrderDate, Status, TotalAmount) VALUES
('John Doe', GETDATE(), 'Pending', 1999.98),
('Jane Smith', GETDATE(), 'Shipped', 299.90);

-- Insert sample data into SalesOrderDetails
INSERT INTO SalesOrderDetails (SalesOrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 2, 999.99),  -- 2 Laptops
(2, 2, 2, 149.99);  -- 2 Office Chairs

-- Insert sample data into StockMovements
INSERT INTO StockMovements (ProductID, MovementType, Quantity, MovementDate, Description) VALUES
(1, 'IN', 10, GETDATE(), 'New stock received for Laptops'),
(2, 'OUT', 5, GETDATE(), 'Sold 5 Office Chairs'),
(3, 'ADJUSTMENT', -5, GETDATE(), 'Damaged 5 T-Shirts');

-- Insert sample data into Users
INSERT INTO Users (Username, PasswordHash, Role) VALUES
('admin', 'hashed_password_1', 'Admin'),
('manager', 'hashed_password_2', 'Manager'),
('staff', 'hashed_password_3', 'Staff');

-- Insert sample data into AuditLogs
INSERT INTO AuditLogs (UserID, Action, TableAffected, ActionTime, Description) VALUES
(1, 'Created new product', 'Products', GETDATE(), 'Added Laptop'),
(2, 'Updated stock quantity', 'StockMovements', GETDATE(), 'Adjusted stock for Office Chair'),
(3, 'Deleted a sales order', 'SalesOrders', GETDATE(), 'Removed order for John Doe');