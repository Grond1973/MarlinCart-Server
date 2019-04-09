using MarlinCart.Common;
using System.Collections.Generic;

namespace MarlinCartDAL
{
    public interface IMarlinCartDAL
    {
        List<Product> GetCartProducts();

        List<StateVO> GetStates();

        List<CreditCardVO> GetCreditCards();
    }
}
