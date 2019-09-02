using EFentity;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class DALClient : DaoBase<config_public_char>, IFDALClient
    {
        public int ADDClient(config_public_charModel cm)
        {
            config_public_char c = new config_public_char()
            {
                attribute_kind = "薪资设置",
                attribute_name = cm.attribute_name
            };
            return Add(c);
        }

        public int ADDPublic_char(config_public_charModel cm)
        {
            config_public_char c = new config_public_char()
            {
                attribute_kind = cm.attribute_kind,
                attribute_name = cm.attribute_name
            };
            return Add(c);
        }
        public int DELETEClient(config_public_charModel cm)
        {
            config_public_char c = new config_public_char()
            {
                Id = cm.Id
            };
            return Delete(c);
        }

        public List<config_public_charModel> SELECTClient()
        {
            List<config_public_char> list = SelectAll();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel cm = new config_public_charModel()
                {
                    attribute_kind=item.attribute_kind,
                    attribute_name = item.attribute_name,
                    Id=item.Id
                };
                list2.Add(cm);
            }
            return list2;
        }

        public List<config_public_charModel> SelectWhere(string name)
        {
            List<config_public_char> list = SelectBy(e => e.attribute_kind.Equals(name));
            List<config_public_charModel> list1 = new List<config_public_charModel>();
            foreach (var item in list)
            {
                config_public_charModel c = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_name = item.attribute_name,
                    attribute_kind = item.attribute_kind,
                };
                list1.Add(c);
            }
            return list1;
        }

        public int UPDATEClient(config_public_charModel cm)
        {
            throw new NotImplementedException();
        }
    }
}
