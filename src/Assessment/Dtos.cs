using System;
using System.ComponentModel.DataAnnotations;

namespace Assessment.Dtos
{
    // used to return withdrawal and account data
    public record AccDto(Guid Id, string accName,string accType,string name,string status,decimal accBalance, DateTimeOffset CreatedAt);
    
    //used to create new withdrawals
    public record CreateAccDto([Required] string accName,[Required] string accType,[Required] string name,[Required] string status,decimal accBalance);

    // used to update withdrawals
    public record UpdateAccDto( string accName,string accType,string name,string status,decimal accBalance);
}