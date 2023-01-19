using Microsoft.VisualBasic;

namespace program_1
{
    public partial class Form1 : Form
    {
        double Grossincome ,  deduction ,adjGross;

        private void Taxes_at10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adj_Gross_TextChanged(object sender, EventArgs e)
        {

        }

        const int standardDeductin = 12_950;
        public Form1()
        {
            InitializeComponent();
        }

        private void Single_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Married_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrossIncome_TextChanged(object sender, EventArgs e)
        {
            Grossincome= Convert.ToDouble(GrossIncome.Text);
        }

        private void TaxOwed_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gross_income_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void adj_income_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deduction_TextChanged(object sender, EventArgs e)
        {
            deduction = Convert.ToDouble(Deduction.Text);
            if (deduction < 12950)
            {
                deduction = standardDeductin;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Single.Checked)
            {

                const int deduction_at_10 = 0;
                const int deduction_at_12 = 10_275;
                const int deduction_at_22 = 41_775;
                const int deduction_at_24 = 89_075;
                const int deduction_at_32 = 170_050;
                const int deduction_at_35 = 215_950;
                const int deduction_at_37 = 539_900;

                double getTaxesat(double income, double start, double end, double taxRate)
                {
                    if (income < end)
                    {
                        return (end - start) * taxRate;
                    }
                    else if (income < start)
                    {
                        return 0;
                    }
                    else
                    {
                        return (end - start) * taxRate;
                    }
                }


                
                adjGross = Grossincome - deduction;
                
                double taxOwedat10 = getTaxesat(adjGross, deduction_at_10, deduction_at_12, .10);
                double taxOwedat12 = getTaxesat(adjGross, deduction_at_12, deduction_at_22, .12);
                double taxOwedat22 = getTaxesat(adjGross, deduction_at_22, deduction_at_24, .22);
                double taxOwedat24 = getTaxesat(adjGross, deduction_at_24, deduction_at_32, .24);
                double taxOwedat32 = getTaxesat(adjGross, deduction_at_32, deduction_at_35, .32);
                double taxOwedat35 = getTaxesat(adjGross, deduction_at_35, deduction_at_37, .35);
                double taxOwedat37 = getTaxesat(adjGross, deduction_at_37, adjGross, .37);

                Taxes_at10.Text = taxOwedat10.ToString();
                Taxes_at12.Text = taxOwedat12.ToString();
                Taxes_at22.Text = taxOwedat22.ToString();
                Taxes_at24.Text = taxOwedat24.ToString();
                Taxes_at32.Text = taxOwedat32.ToString();
                Taxes_at35.Text = taxOwedat35.ToString();
                Taxes_at37.Text = taxOwedat37.ToString();

                double tax10 = Convert.ToDouble(Taxes_at10.Text);
                double tax12 = Convert.ToDouble(Taxes_at12.Text);
                double tax22 = Convert.ToDouble(Taxes_at22.Text);
                double tax24 = Convert.ToDouble(Taxes_at24.Text);
                double tax32 = Convert.ToDouble(Taxes_at32.Text);
                double tax35 = Convert.ToDouble(Taxes_at35.Text);
                double tax37 = Convert.ToDouble(Taxes_at37.Text);
                double sum = tax10+ tax12 + tax22 + tax24+ tax32+tax35+tax37;
                TaxOwed.Text = sum.ToString();
                Adj_Gross.Text= adjGross.ToString();
                double PerGrossIncome = (sum / Grossincome)*100;
                Gross_income.Text= PerGrossIncome.ToString();
                double PerAdjIncome = (sum / adjGross) * 100;
                adj_income.Text = PerAdjIncome.ToString();

            }
            if (Married.Checked)
            {

                const int deduction_at_10 = 0;
                const int deduction_at_12 = 20_550;
                const int deduction_at_22 = 83_550;
                const int deduction_at_24 = 178_150;
                const int deduction_at_32 = 340_100;
                const int deduction_at_35 = 431_900;
                const int deduction_at_37 = 647_850;
                adjGross = Grossincome - deduction;

                double getTaxesat(double adjGross, double start, double end, double taxRate)
                {
                    if (adjGross > end)
                    {
                        return (end - start) * taxRate;
                    }
                    else if (adjGross < start)
                    {
                        return 0;
                    }
                    else
                    {
                        return (end - start) * taxRate;
                    }
                }



                

                double taxOwedat10 = getTaxesat(adjGross, deduction_at_10, deduction_at_12, .10);
                double taxOwedat12 = getTaxesat(adjGross, deduction_at_12, deduction_at_22, .12);
                double taxOwedat22 = getTaxesat(adjGross, deduction_at_22, deduction_at_24, .22);
                double taxOwedat24 = getTaxesat(adjGross, deduction_at_24, deduction_at_32, .24);
                double taxOwedat32 = getTaxesat(adjGross, deduction_at_32, deduction_at_35, .32);
                double taxOwedat35 = getTaxesat(adjGross, deduction_at_35, deduction_at_37, .35);
                double taxOwedat37 = getTaxesat(adjGross, deduction_at_37, adjGross, .37);

                Taxes_at10.Text = taxOwedat10.ToString();
                Taxes_at12.Text = taxOwedat12.ToString();
                Taxes_at22.Text = taxOwedat22.ToString();
                Taxes_at24.Text = taxOwedat24.ToString();
                Taxes_at32.Text = taxOwedat32.ToString();
                Taxes_at35.Text = taxOwedat35.ToString();
                Taxes_at37.Text = taxOwedat37.ToString();

                double tax10 = Convert.ToDouble(Taxes_at10.Text);
                double tax12 = Convert.ToDouble(Taxes_at12.Text);
                double tax22 = Convert.ToDouble(Taxes_at22.Text);
                double tax24 = Convert.ToDouble(Taxes_at24.Text);
                double tax32 = Convert.ToDouble(Taxes_at32.Text);
                double tax35 = Convert.ToDouble(Taxes_at35.Text);
                double tax37 = Convert.ToDouble(Taxes_at37.Text);
                double sum = tax10 + tax12 + tax22 + tax24 + tax32 + tax35 + tax37;
                TaxOwed.Text = sum.ToString();
                Adj_Gross.Text = adjGross.ToString();
                double PerGrossIncome = (sum / Grossincome) * 100;
                Gross_income.Text = PerGrossIncome.ToString();
                double PerAdjIncome = (sum / adjGross) * 100;
                adj_income.Text = PerAdjIncome.ToString();


            }

        }
    }
}