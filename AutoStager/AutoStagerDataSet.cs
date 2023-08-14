using System.Diagnostics;

namespace AutoStager
{


    partial class AutoStagerDataSet
    {
        [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
        partial class MovingCrewDataTable
        {
            private string GetDebuggerDisplay()
            {
                return ToString();
            }
        }
    }
}

namespace AutoStager.AutoStagerDataSetTableAdapters {
    
    
    public partial class MovingCrewTableAdapter {
    }
}
