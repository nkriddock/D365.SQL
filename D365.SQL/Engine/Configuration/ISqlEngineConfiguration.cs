namespace D365.SQL.Engine.Configuration
{
    using DML.Select;

    internal interface ISqlEngineConfiguration
    {
        SqlEngineSettings Settings { get; set; }

        ISqlEngineStatementConfiguration<SelectStatement> SelectStatementConfiguration { get; }
    }
}