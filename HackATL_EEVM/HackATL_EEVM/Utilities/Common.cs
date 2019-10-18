using HackATL_EEVM.Models;
using HackATL_EEVM.Services.Item_realted;
using HackATL_EEVM.Views.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Utilities
{
    
    
    public static class Common
    {
        

        public static MasterMainPageDetail MasterPage { get; set; }
        
        public static List<TypesModel> typesModel = new List<TypesModel>();
        public static List<TypesModel> typesModelFRI = new List<TypesModel>();
        public static List<TypesModel> typesModelSAT = new List<TypesModel>();
        public static List<TypesModel> typesModelSUN = new List<TypesModel>();

        public static List<TypesModel> mytypesModel = new List<TypesModel>();
        public static List<TypesModel> mytypesModelFRI = new List<TypesModel>();
        public static List<TypesModel> mytypesModelSAT = new List<TypesModel>();
        public static List<TypesModel> mytypesModelSUN = new List<TypesModel>();
    }
}
