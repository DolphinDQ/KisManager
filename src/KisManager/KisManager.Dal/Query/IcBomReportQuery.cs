namespace KisManager.Dal.Query
{
    public class IcBomReportQuery
    {
        public int? Year { get; set; }

        public short? Month { get; set; }

        public int? StockId { get; set; }

        public string BomNo { get; set; }

        public string ProductNo { get; set; }
    }
}
