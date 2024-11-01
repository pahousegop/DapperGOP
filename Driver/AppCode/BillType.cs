

using System.ComponentModel.DataAnnotations.Schema;

namespace DTO;


public class BillType
{ 

    public BillType()
    {
    }


    #region "Properties ------------------------------------------------------------------------"

    public int BillTypeID { get; set; }

    public string? Dataset { get; set; }

    public string? Description { get; set; }

    public string? BillNumber { get; set; }

    [Column("BillType")]
    public string? TypeOfBill { get; set; }

    public string? SessionYear { get; set; }

    public string? SessionType { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

 
   
    #endregion


}
