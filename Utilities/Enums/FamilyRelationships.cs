using System.ComponentModel;

namespace Utilities.Enums
{
    /// <summary>
    /// سرپرست خانواده(0) - پدر(1) - مادر(2) - دختر(3) - پسر(4) - شوهر(5) - زن(6) - برادر(7) - خواهر(8) - نوه پسر(9) - نوه دختر(10) - مادربزرگ(11) - پدربزرگ(12)ه
    /// </summary>

    public enum FamilyRelationships
    {
        [Description("سرپرست خانواده")]
        FamilyHead = 0,
        [Description("پدر")]
        Father = 1,
        [Description("مادر")]
        Mother = 2,
        [Description("دختر")]
        Daughter = 3,
        [Description("پسر")]
        Son = 4,
        [Description("شوهر")]
        Husband = 5,
        [Description("زن")]
        Wife = 6,
        [Description("برادر")]
        Brother = 7,
        [Description("خواهر")]
        Sister = 8,
        [Description("نوه پسر")]
        GrandSon = 9,
        [Description("نوه دختر")]
        GrandDaughter = 10,
        [Description("مادربزرگ")]
        GrandMother = 11,
        [Description("پدربزرگ")]
        GrandFather = 12,
    }
}
