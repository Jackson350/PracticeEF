using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace samplesDF.Services
{
    public class EmployeeService
    {

        public List<EmployeeInfo> GetEmployees(string name, string lastname, string gender, string orderbyColumn, string orderbyDirection, int pageNumber, int pageSize, out int totalRows)
        {
            using (AdventureWorks2012Entities db = new AdventureWorks2012Entities())
            {
                IQueryable<EmployeeInfo> query =
                (from empl in db.Employee
                 let person = empl.Person
                 select new EmployeeInfo
                 {
                     name = person.FirstName,
                     lastname = person.LastName,
                     orglevel = (int)empl.OrganizationLevel,
                     jobtitle = empl.JobTitle,
                     birthdate = empl.BirthDate,
                     gender = empl.Gender
                 });
                #region Apply Filters
                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(p => p.name == name);
                }
                if (!string.IsNullOrWhiteSpace(lastname))
                {
                    query = query.Where(p => p.lastname == lastname);
                }
                if (!string.IsNullOrWhiteSpace(gender))
                {
                    query = query.Where(p => p.gender == gender);
                }

                if (!string.IsNullOrWhiteSpace(orderbyColumn) && !string.IsNullOrWhiteSpace(orderbyDirection))
                {
                    switch (orderbyColumn)
                    {
                        case "name":
                            {                                
                                if (orderbyDirection=="asc")
                                    query = query.OrderBy(p => p.name);
                                else
                                    query = query.OrderByDescending(p => p.name);
                                break;
                            }
                        case "lastname":
                            {
                                if (orderbyDirection == "asc")
                                    query = query.OrderBy(p => p.lastname);
                                else
                                    query = query.OrderByDescending(p => p.lastname);
                                break;
                            }
                        case "orglevel":
                            {
                                if (orderbyDirection == "asc")
                                    query = query.OrderBy(p => p.orglevel);
                                else
                                    query = query.OrderByDescending(p => p.orglevel);
                                break;
                            }
                        case "jobtitle":
                            {
                                if (orderbyDirection == "asc")
                                    query = query.OrderBy(p => p.jobtitle);
                                else
                                    query = query.OrderByDescending(p => p.jobtitle);
                                break;
                            }
                        case "birthdate":
                            {
                                if (orderbyDirection == "asc")
                                    query = query.OrderBy(p => p.birthdate);
                                else
                                    query = query.OrderByDescending(p => p.birthdate);
                                break;
                            }
                        case "gender":
                            {
                                if (orderbyDirection == "asc")
                                    query = query.OrderBy(p => p.gender);
                                else
                                    query = query.OrderByDescending(p => p.gender);
                                break;
                            }
                        default:
                            break;
                    }
                }                
                #endregion

                totalRows = query.Count();

                //Paging
                query = query.Skip(pageNumber - 1).Take(pageSize);

                //Materialization
                return query.ToList();

            }
        }
    }
}
