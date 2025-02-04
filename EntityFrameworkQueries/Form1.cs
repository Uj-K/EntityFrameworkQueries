using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using System.Text;

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

            /* LINQ Method Syntax
             * (Language Integrated Query)*/ 
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            /* LINQ Query Syntax
             * SQL 에서 하던대로 하는거고 위에는 C#스타일로 하는거네*/
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();


        }

        private void btnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new();

            List<Vendor> VendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();

            List<Vendor> VendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();
            // Anonymous type
            /*특정 형식에 대한 이름을 정의하지 않고, 프로퍼티와 값을 가질 수 있는 객체
             * 특정 상황에서 간편하게 사용할 수 있지만, 일반적으로는 이름이 있는 명시적 클래스를 사용하는 것이 좋음
             * 왜나면 코드의 가독성 및 유지보수성을 높일 수 있으니까*/
            var results = (from v in dbContext.Vendors
                           select new
                           {
                               v.VendorName,
                               v.VendorState,
                               v.VendorCity
                           }).ToList();
            /*StringBuilder 클래스는 문자열을 효율적으로 조작할 수 있도록 도와주는 클래스입니다. 
             * 기본적으로 불변(immutable)인 String 클래스와 달리, 
             * StringBuilder는 가변(mutable) 문자열을 사용하여 
             * 여러 번의 문자열 조작 작업을 더 효율적으로 처리할 수 있습니다. 
             * 주로 문자열을 자주 추가, 수정, 삭제해야 하는 경우에 유용합니다.*/
            StringBuilder displayString = new();
            foreach (var vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            ApContext dbContect = new();

            // Check if any WA vendor exists
            bool doesExist = (from v in dbContect.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            //Get number of Invoices
            int invoiceCount = (from invoice in dbContect.Invoices
                                select invoice).Count();


            //Query a single Vendor
            Vendor ? singleVendor = (from v in dbContect.Vendors
                                     where v.VendorName == "IBM"
                                     select v).SingleOrDefault(); // 하나가 아닐수도 있으니까 이렇게 한다

            if (singleVendor != null) 
            { 
                // do something
            }            
        }
    }
    /* 여기에 class 를 선언하여 Anonymous Type(익명 형식)을 쓰지 않고
     * explicit type 을 명시해 줄수도 있다.*/
}
