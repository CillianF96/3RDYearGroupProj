namespace BusinessEntities
{
    public interface IVoucher
    {
        int VoucherID { get; set; }

        double Amount { get; set; }

        string Name { get; set; }

        string Type { get; set; }

        string Message { get; set; }

        string GetVoucher();
        string PrintVoucherDetails();

    }
}
