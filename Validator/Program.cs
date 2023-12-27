using System.Text.RegularExpressions;
using System.Windows.Forms;
using ValidatingBase;


class Program
{
    private static object emailTextBox;

    static void Main(string[] args)
    {
        ValidatingBase.ValidatingBase validator = new ValidatingBase.ValidatingBase();
        if (emailTextBox.Text != null && !validator.Email_Address().IsMatch(emailTextBox.Text))
        {
            validator.emptymessage();
        }

    }
}
