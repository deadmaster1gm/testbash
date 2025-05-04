namespace Data;
public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
    var OnlyInteger = listOfItems.OfType<int>();
    List <int> NoSortInteger = [];
    foreach(var c in OnlyInteger){
        NoSortInteger.Add(c);
    }
    return NoSortInteger;
   }
}