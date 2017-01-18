using System;

namespace T3
{
    public partial class Default : System.Web.UI.Page
    {
        private bool isSecondLevel
        {
            get
            {
                return Convert.ToBoolean(ViewState["isSecondLevel"]);
            }
            set
            {
                ViewState["isSecondLevel"] = value.ToString();
            }
        }

        private string FirstNumber
        {
            get
            {
                    return ViewState["FirstLevel"].ToString();
                
            }
            set
            {
                ViewState["FirstLevel"] = value;
            }
        }

        private string SecondNumber
        {
            get
            {
               
                    return ViewState["SecondLevel"].ToString();
                
            }
            set
            {
                ViewState["SecondLevel"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                isSecondLevel = false;
                ViewState["SecondLevel"] = string.Empty;
                ViewState["FirstLevel"] = string.Empty;
            }
        }

        protected void btnOne_Click(object sender, EventArgs e)
        {
            PerformClick(1);
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            PerformClick(2);
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            PerformClick(3);
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            PerformClick(4);
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            PerformClick(5);
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            PerformClick(6);
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            PerformClick(7);
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            PerformClick(8);
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            PerformClick(9);
        }

        protected void BtnZero_Click(object sender, EventArgs e)
        {
            PerformClick(0);
        }

        private void PerformClick(int number)
        {
            if (isSecondLevel)
            {
                SecondNumber += number.ToString();
                tbxResult.Text = SecondNumber;
            }
            else
            {
                FirstNumber += number.ToString();
                tbxResult.Text = FirstNumber;
            }
        }
        private void PerformActionClick(int number)
        {
            if (isSecondLevel)
            {
                CalculateResult();
                FirstNumber = tbxResult.Text;
                
                ViewState["Action"] = number.ToString();

                SecondNumber = string.Empty;

            }
            {
                ViewState["Action"] = number.ToString();
                isSecondLevel = true;
            }
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            PerformActionClick(Convert.ToInt16(Operations.Plus));
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            PerformActionClick(Convert.ToInt16(Operations.Divide));
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            PerformActionClick(Convert.ToInt16(Operations.Minus));
        }

        protected void btnMultipl_Click(object sender, EventArgs e)
        {
            PerformActionClick(Convert.ToInt16(Operations.Multip));
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            CalculateResult();
            ViewState.Clear();
        }

        private void CalculateResult()
        {
            int result = 0;

            switch ((Operations)Convert.ToInt16(ViewState["Action"]))
            {
                case Operations.Divide:
                    result = Convert.ToInt32(FirstNumber) / Convert.ToInt32(SecondNumber);
                    break;

                case Operations.Minus:
                    result = Convert.ToInt32(FirstNumber) - Convert.ToInt32(SecondNumber);
                    break;

                case Operations.Plus:
                    result = Convert.ToInt32(FirstNumber) + Convert.ToInt32(SecondNumber);
                    break;

                case Operations.Multip:
                    result = Convert.ToInt32(FirstNumber) * Convert.ToInt32(SecondNumber);
                    break;
            }

            tbxResult.Text = result.ToString();
            isSecondLevel = false;
        }

        protected void btnCencel_Click(object sender, EventArgs e)
        {
            ViewState.Clear();
            tbxResult.Text = string.Empty;
            isSecondLevel = false;
        }
    }
}