namespace WebSisParApi.Repositories.StatisticRepository
{
    public interface IStatisticRepository
    {
        int Count();
        decimal GetAverage();
        string EmployeeMaxPerformans();

    }
}
