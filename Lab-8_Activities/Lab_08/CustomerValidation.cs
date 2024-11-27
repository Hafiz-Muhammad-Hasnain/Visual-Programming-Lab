using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Activity_01_Lab
{
    internal class CustomerValidation
    {
        public void checkCustomerName(string name)
        {
            if(name.Length > 10)
            {
                throw new Exception("Name should be within 10 characters.");
            }
            else if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name is Required");
            }
        }

        public void checkGender(RadioButton male,RadioButton female)
        {
            if (!male.Checked && !female.Checked)
            {
                throw new Exception("Select your Gender");
            }
            
        }

        public void checkHobby(CheckBox one, CheckBox two)
        {
            if (!one.Checked && !two.Checked)
            {
                throw new Exception("Select your Hobby");
            }

        }

        public void checkStatus(RadioButton m, RadioButton um)
        {
            if (!m.Checked && !um.Checked)
            {
                throw new Exception("Select your Status");
            }

        }

    }
}
