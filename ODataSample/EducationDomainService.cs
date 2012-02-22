
namespace ODataSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // TODO: アプリケーション ロジックを含むメソッドを作成します。
    [EnableClientAccess()]
    public class EducationDomainService : DomainService
    {
        [Query(IsDefault = true)]
        public IQueryable<Person> GetPeople()
        {
            return new[] { new Person { ID = 0, Name = "田中　太郎" } }.AsQueryable();
        }
    }
}


