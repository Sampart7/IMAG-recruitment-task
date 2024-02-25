namespace RecruitmentTaskShared.Entities
{
    public record struct CustomerResponse(List<Customer> Customers, int Count);
}