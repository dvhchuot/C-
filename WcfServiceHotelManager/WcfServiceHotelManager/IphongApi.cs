using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceHotelManager.Entity;

namespace WcfServiceHotelManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IphongApi" in both code and config file together.
    [ServiceContract]
    public interface IphongApi
    {
        [OperationContract]
        List<phong> getListPhong(int id_lp = -1);
        [OperationContract]
        chitietdatphong getPhongById(int idPhong);
        [OperationContract]
        chitietdatphong getPhieuDatPhongById(int idPdp);
        [OperationContract]
        int ktraPhong(int idPhong);
        [OperationContract]
        List<chitietdichvu> getDichVuPdp(int idPdp);
        [OperationContract]
        bool traphong(int idPdp, double tongtien, string username, int idp);
        [OperationContract]
        List<dichvu> getListDichVu();
        [OperationContract]
        bool themdv(int iddv, int idpdp, int soluong);
        [OperationContract]
        List<loaidichvu> getLoaidichvu();
        [OperationContract]
        bool updatedv(dichvu dv);
        [OperationContract]
        bool xoadv(int id);
    }
}
