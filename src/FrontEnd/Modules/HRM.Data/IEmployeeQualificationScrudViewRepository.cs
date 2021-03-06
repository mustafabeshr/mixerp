// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeQualificationScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeQualificationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeQualificationScrudView" class from IEmployeeQualificationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeQualificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualificationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeQualificationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeQualificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualificationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeQualificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualificationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeQualificationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeQualificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeQualificationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeQualificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeQualificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualificationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}