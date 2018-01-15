using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INC.DomainModel.Model;
namespace INC.DataAccessLayer.Interfaces
{
    public class IncomingRepository
    {

    }
    public interface ISwiftMsgInc : IGenericDataRepository<swift_msg_inc>
    {
    }
    public interface ISwiftMsgTxt : IGenericDataRepository<swift_msg_txt>
    {
    }
    public interface ISwiftPrn : IGenericDataRepository<swift_prn>
    {

    }

    public class SwiftMsgIncRepository : GenericDataRepository<swift_msg_inc>, ISwiftMsgInc
    {
    
    }
    public class SwiftMsgTxtRepository : GenericDataRepository<swift_msg_txt>, ISwiftMsgTxt
    {
    }
    public class SwiftPrnRepository : GenericDataRepository<swift_prn>, ISwiftPrn
    {

    }
}
