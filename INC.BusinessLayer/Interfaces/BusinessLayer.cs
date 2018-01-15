using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INC.DomainModel.Model;
using INC.DataAccessLayer.Interfaces;

namespace INC.BusinessLayer.Interfaces
{
    
    public class BusinessLayer : IBusinessLayer
    {
        private readonly SwiftMsgIncRepository _swiftMsgIncRepository;
        private readonly SwiftMsgTxtRepository _swiftMsgTxtRepository;

        public BusinessLayer()
        {
            _swiftMsgIncRepository = new SwiftMsgIncRepository();
            _swiftMsgTxtRepository = new SwiftMsgTxtRepository();
        
        }

        public BusinessLayer(SwiftMsgIncRepository swiftMsgIncRepository, SwiftMsgTxtRepository swiftMsgTxtRepository)
        {
            _swiftMsgIncRepository = swiftMsgIncRepository;
            _swiftMsgTxtRepository = swiftMsgTxtRepository;

        }

        public IList<swift_msg_inc> GetAllSwiftMsgInc()
        {
           return  _swiftMsgIncRepository.GetAll();
        }

        public swift_msg_inc Get_SwiftMsgIncById(decimal Id)
        {
            return _swiftMsgIncRepository.GetSingle(r => r.rec_no == Id);
        }

        public swift_msg_txt Get_SwiftMsgTxtById(decimal Id)
        {
            throw new NotImplementedException();
        }
    }
    public interface IBusinessLayer
    {

        IList<swift_msg_inc> GetAllSwiftMsgInc();
        swift_msg_inc Get_SwiftMsgIncById(decimal Id);

        //IList<swift_msg_txt GetAllSwiftMsgTxt();
        swift_msg_txt Get_SwiftMsgTxtById(decimal Id);

    }
}
