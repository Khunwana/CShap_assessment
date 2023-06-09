namespace Assessment.Dtos
{
    // used to return withdrawal and account data
    public record AccDto(Guid Id, string accName,string accType,string name,string status,decimal accBalance, DateTimeOffset CreatedAt);
    
    //used to create new withdrawals
    public record CreateAccDto( string accName,string accType,string name,string status,decimal accBalance);

    // used to update withdrawals
    public record UpdateAccDto( string accName,string accType,string name,string status,decimal accBalance);
}