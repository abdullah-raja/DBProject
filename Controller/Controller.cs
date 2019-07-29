using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;
using DBproject.Views.UserControls;
using System.Data.SqlClient;
using DBproject.Util.StoredProcedures;
using DBproject.Util.Tables;
using System.Data.Sql;


namespace DBproject.Controller
{
    abstract class ControllerModule
    {
        protected string TABLE_NAME;
        

        protected string connectionString;
        protected SqlConnection connection;

        public ControllerModule()
        {

        }

        public ControllerModule(string connectionString, string TableName)
        {
            this.TABLE_NAME = TableName;
            try
            {
                this.connectionString = connectionString;
                this.connection = new SqlConnection(this.connectionString);
            }

            catch (Exception es)
            {

            }

        }

        virtual public bool signUp(Model.User user, Views.SignUp view)
        {
            return false;
        }

        virtual public void signIn(Model.User user, Views.SignUp view, string enteredEmail, string enteredPassword, Model.Building apartment)
        {

        }


        virtual public void createBuilding(Model.Building building, Views.SignUp view, Model.User user, int adminFlat
            )
        {
            

        }

        virtual public void showDetailsPanel(Flat flat, Views.UserControls.Income view)
        {

        }

        virtual public void updateDetailsPanel(Flat flat)
        {

        }

        virtual public void confirmTransaction(IncomingTransaction transaction, Building apartment, Income view)
        {
            
        }

        virtual public void sendEmail(string email, Receipt receipt)
        {

        }

        virtual public void showPaidReceipt(Receipt recipt, string month, int flatNumber)
        {

        }

        virtual public void setMonths(Income view, int year)
        {

        }

        virtual public void setMonths(Expense view, int year)
        {

        }

        virtual public void setMonths(MainScreen view, int year, Building apartment)
        {

            List<String> months = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_EXPENSES.KEY_MONTH + " FROM " + TABLE_EXPENSES.TABLE_NAME + " WHERE " + TABLE_EXPENSES.KEY_YEAR + " = " + year + " AND " + TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";
            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader monthReader = command.ExecuteReader())
                {
                    while (monthReader.Read())
                    {
                        months.Add(monthReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString().ToUpper());
                    }
                }
            }

            connection.Close();
            view.setMonths(months);
        }

        virtual public void setYears(Income view)
        {

        }

        virtual public void setYears(MainScreen view, Building apartment)
        {
            List<String> years = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_EXPENSES.KEY_YEAR + " FROM " + TABLE_EXPENSES.TABLE_NAME + " WHERE " + TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";

            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader yearReader = command.ExecuteReader())
                {
                    while (yearReader.Read())
                    {
                        years.Add(yearReader[TABLE_INCOMING_TRANSACTIONS.KEY_YEAR].ToString());
                    }
                }
            }

            connection.Close();
            view.setYears(years);
        }
        virtual public void setYears(Expense view)
        {

        }

        virtual public void updateBalance(Building apartment, MainScreen view)
        {

        }

        virtual public void newMonthStarted(Building apartment)
        {
            SqlCommand command = new SqlCommand(Util.StoredProcedures.MONTH_STARTED_SP.SP_NAME, connection);
            connection.Open();
            command.ExecuteNonQuery();
            for(int i = 0; i < apartment.getNoOfFloors(); i++)
            {
                for(int j = 0; j < apartment.getFlatsPerFloor(); j++)
                {
                    apartment.getFlatAt(i, j).updateDues();
                }
            }
        }

        virtual public void addExpense(Expense view, bool regularActive, ExpenseDetails expDetails)
        {

        }

        virtual public void addExpense(ExpenseDetails expDetails)
        {

        }

        virtual public void getAllExpense(List<ExpenseCard> expenses, Building apartment, string month, int year)
        {

        }

        virtual public void confirmPayment(OutgoingTransaction transaction, ExpenseCard expense)
        {

        }

        virtual public void deleteExpense(ExpenseDetails expense)
        {

        }

        virtual public void showIncomePieChart(Anaytics view, Building apartment)
        {

        }

        virtual public void showExpensePieChart(Anaytics view, Building apartment)
        {

        }

        virtual public void generateReprt(ReportDialogBox view ,Building apartment, int month, int year)
        {

        }

        virtual public void setMonthAndYears(ReportDialogBox view, Building apartment)
        {

        }

        virtual public void joinApartment(string id, string code, Views.SignUp view)
        {

        }

        virtual public void joinFlat(User user, SignUp view, string id, Building apartment, int flatNumber)
        {

        }

        

        protected void updateFlat(User user)
        {

            connection.Open();
            SqlCommand updateCommand = new SqlCommand(UPDATE_FLAT_USER_SP.SP_NAME, connection);
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.FLAT_PARAM, user.getFlat().getFlatNumber()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.USER_ID_PARAM, Guid.Parse(user.getID())));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.EMAIL_PARAM, user.getEmail()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.MOBILE_NUM_PARAM, user.getMobileNumber()));

            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.APARTMENT_ID_PARAM, Guid.Parse(user.getApartmentID())));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.NAME_PARAM, user.getFirstName() + " " + user.getLastname()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_USER_SP.IS_MANAGER_PARAM, user.getFlat().getIsManager()));

            updateCommand.ExecuteNonQuery();
            connection.Close();

        }

        protected void getAllFlats(Building apartment)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM " + TABLE_FLATS.TBL_FLATS + " WHERE " + TABLE_BUILDING.KEY_APPARTMENT_ID + " = '" + Guid.Parse(apartment.getID()) + "'";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for(int i = 0; i < apartment.getNoOfFloors(); i++)
                    {
                        for(int j = 0; j < apartment.getFlatsPerFloor(); j++)
                        {
                            if (reader.Read())
                            {
                                try
                                {
                                    Flat newFlat = new Model.Flat(Convert.ToInt32(reader[TABLE_FLATS.KEY_FLAT_NUMBER]), reader[TABLE_FLATS.KEY_RESIDENT_NAME].ToString(), reader[TABLE_FLATS.KEY_EMAIL].ToString(), reader[TABLE_FLATS.KEY_MOBILE_NUMBER].ToString(), Convert.ToInt32(reader[TABLE_FLATS.KEY_DUES]), Convert.ToInt32(reader[TABLE_FLATS.KEY_MONTHLYFEE]), Convert.ToInt32(reader[TABLE_FLATS.KEY_IS_MANAGER]), apartment);
                                    
                                    apartment.setFlatAt(newFlat.getFlatNumber(), newFlat);
                                    if (newFlat.getIsManager() == 3)
                                        apartment.makeAdmin(newFlat.getFlatNumber());
                                }

                                catch
                                {
                                    string name;
                                    var r = reader[TABLE_FLATS.KEY_RESIDENT_NAME].Equals(DBNull.Value) ? name = "" : name = reader[TABLE_FLATS.KEY_RESIDENT_NAME].ToString();

                                    string email;
                                    r = reader[TABLE_FLATS.KEY_EMAIL].Equals(DBNull.Value) ? email = "" : email = reader[TABLE_FLATS.KEY_EMAIL].ToString();

                                    string mobile;
                                    r = reader[TABLE_FLATS.KEY_MOBILE_NUMBER].Equals(DBNull.Value) ? mobile = "" : mobile = reader[TABLE_FLATS.KEY_MOBILE_NUMBER].ToString();

                                    int dues;
                                    var a = reader[TABLE_FLATS.KEY_DUES].Equals(DBNull.Value) ? dues = 0 : dues = (int)reader[TABLE_FLATS.KEY_DUES];

                                    int fee;
                                    a = reader[TABLE_FLATS.KEY_MONTHLYFEE].Equals(DBNull.Value) ? fee = 0 : fee = (int)reader[TABLE_FLATS.KEY_MONTHLYFEE];

                                    Flat newFlat = new Model.Flat(Convert.ToInt32(reader[TABLE_FLATS.KEY_FLAT_NUMBER]), name, email, mobile, dues, fee, Convert.ToInt32(reader[TABLE_FLATS.KEY_IS_MANAGER]), apartment);

                                    apartment.setFlatAt(newFlat.getFlatNumber(), newFlat);
                                    if (newFlat.getIsManager() == 3)
                                        apartment.makeAdmin(newFlat.getFlatNumber());


                                    


                                }
                            }
                        }
                    }

                }
            }

            connection.Close();
        }

        virtual public void updateBarGraphData(Views.UserControls.Graphs.BarGraph bar, int year, Building apartment)
        {

        }
    }
}
