namespace DepotDumper
{
    class DumpConfig
    {
        public int CellID { get; set; }

        public string DumpDirectory { get; set; }
        public string SuppliedPassword { get; set; }
        public bool RememberPassword { get; set; }

        // A Steam LoginID to allow multiple concurrent connections
        public uint? LoginID { get; set; }
    }
}
