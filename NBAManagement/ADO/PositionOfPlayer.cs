//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBAManagement.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PositionOfPlayer
    {
        public int PositionOfPlayerID { get; set; }
        public int PositionID { get; set; }
        public int PlayerID { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual PositionName PositionName { get; set; }
    }
}
