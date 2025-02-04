using EntityFrameworkQueries.Models;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            /* 리소스 관리: using 블록을 사용하여 IDisposable 인터페이스를 구현한 객체를 선언하고, 
             * 블록이 종료되면 해당 객체의 Dispose 메서드를 자동으로 호출하여 리소스를 해제합니다. 
             * 주로 파일, 데이터베이스 연결, 네트워크 연결 등의 리소스를 관리할 때 사용됩니다.
             * 선생님은 clean up 이라고 표현하심*/
            using ApContext dbContext = new ApContext();

            // LINQ Method Syntax
            // (Language Integrated Query) 
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ Query Syntax
            // SQL 에서 하던대로 하는거고 위에는 C#스타일로 하는거네
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList ();


        }
    }
}
