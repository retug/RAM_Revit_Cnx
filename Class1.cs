using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAMDATAACCESSLib;

namespace RAM_Revit_Cnx2
{
    public class RAMModel
    {
        public static int GET_GRID_NAMES(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();

            //CLOSE           
            IDBI.CloseDatabase();
            return My_story_count;
        }
        public static int RunStuff()
        {
            string RSSFileName = "I:\\Common\\06 Employee Personal Folders\\Austin Guter\\TestRAMModel\\testModel.rss";
            int x = GET_GRID_NAMES(RSSFileName);
            return x;

        }

        public static List<string> GET_STORY_NAMES(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int Story_Count = My_stories.GetCount();
            List<string> ListLine = new List<string>();
            for (int i = 0; i < Story_Count; i = i + 1)
            {
                string My_Story_Names = My_stories.GetAt(i).strLabel;
                ListLine.Add(My_Story_Names);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }

        public static List<string> GET_GRID_NAMES(string FileName, int StoryCount)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(StoryCount);
            IFloorType My_Floor = My_Story.GetFloorType();

            //IGridSystem My_Grid_System = IModel.GetGridSystem(StoryCount);
            //double dxOffset = My_Grid_System.dXOffset;
            IDAArray IDMy_Gird_Systems = My_Floor.GetGridSystemIDArray();

            //retreives all GridSystems in the model, I would like to get it to the point where you just retreive on a per level basis
            // but we will proceed with this direction for now. It seems like IDAArray should do the trick but the code is confusing
            //We go from  the story of interest, to finding what "floor type" is on that story, to reteiving the "IDArray" for the 
            //floor of interest.


            List<string> ListLine = new List<string>();

            //note, it is not well documented that each grid system has a property that is lUID, struggled to figure this part out.

            IGridSystems allGridSystems = IModel.GetGridSystems();
            for (int i = 0; i < allGridSystems.GetCount(); i = i + 1)
            {
                int My_Grid_ID = allGridSystems.GetAt(i).lUID;
                ListLine.Add(My_Grid_ID.ToString());
            }
            
 
            IDBI.CloseDatabase();
            return ListLine;

        }
    }
}
