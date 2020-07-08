namespace SOLID
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface Segregation Principle:
    /// No client should be forced to depend on methods it does not use.
    /// 
    /// In this case
    /// ISP is a company, it recruit a lot of employees
    /// And record them as a IEmployee
    /// From the company's perspective
    /// The company only needs to know that employees are required to work
    /// </summary>
    public sealed class ISP
    {
        private List<IEmployee> employees = new List<IEmployee>();
        private List<IProgrammer> programmers = new List<IProgrammer>();
        private List<IArtist> artists = new List<IArtist>();
        private List<IGameDesigner> gameDesigners = new List<IGameDesigner>();

        public void RecruitEmployees(params IEmployee[] recruitedEmployees)
        {
            employees.AddRange(recruitedEmployees);
            foreach (var rEmployee in recruitedEmployees)
            {
                AddIntoThisList(rEmployee, programmers);
                AddIntoThisList(rEmployee, artists);
                AddIntoThisList(rEmployee, gameDesigners);
            }
        }

        public void RunCompany()
        {
            employees.ForEach(employee =>
            {
                employee.Work();
            });
        }

        public void UseProgrammer()
        {
            programmers.ForEach(p =>
            {
                p.WriteCode();
                p.Debug();
            });
        }

        public void UseArtist()
        {
            artists.ForEach(a =>
            {
                a.Create2DImage();
                a.Create3DModel();
            });
        }

        public void UseGameDesigner()
        {
            gameDesigners.ForEach(gd =>
            {
                gd.CreateGamePlay();
                gd.CreateUILayout();
            });
        }

        private void AddIntoThisList<T>(IEmployee employee, List<T> list)
        {
            var employeeType = employee.GetType();
            var tType = typeof(T);
            var isAssignable = tType.IsAssignableFrom(employeeType);
            if (isAssignable)
            {
                list.Add((T)employee);
            }
        }
    }
}
