using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EntityFrameworkQueries.Models;

[DebuggerDisplay("Name: {VendorName,nq} - {VendorState,nq}")] // 얘는 디버거를 보여주는 앤데 괄호 안에는 디버거가 어떻게 보여지는지 내가 선택
public partial class Vendor
{
    public int VendorId { get; set; }

    public string VendorName { get; set; } = null!;

    public string? VendorAddress1 { get; set; }

    public string? VendorAddress2 { get; set; }

    public string VendorCity { get; set; } = null!;

    public string VendorState { get; set; } = null!;

    public string VendorZipCode { get; set; } = null!;

    public string? VendorPhone { get; set; }

    public string? VendorContactLname { get; set; }

    public string? VendorContactFname { get; set; }

    public int DefaultTermsId { get; set; }

    public int DefaultAccountNo { get; set; }

    public virtual Glaccount DefaultAccountNoNavigation { get; set; } = null!;

    public virtual Term DefaultTerms { get; set; } = null!;

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
