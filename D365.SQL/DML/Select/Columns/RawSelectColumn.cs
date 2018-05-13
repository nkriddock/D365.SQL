namespace D365.SQL.DML.Select.Columns
{
    internal class RawSelectColumn : SelectColumnBase
    {
        public RawSelectColumn(string label, string value)
            : base(label)
        {
            Value = value;
        }

        public string Value { get; set; }

        public override SelectColumnTypeEnum Type => SelectColumnTypeEnum.Raw;
    }
}