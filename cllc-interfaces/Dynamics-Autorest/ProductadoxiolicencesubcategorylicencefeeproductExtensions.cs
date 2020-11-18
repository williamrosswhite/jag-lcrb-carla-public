// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Productadoxiolicencesubcategorylicencefeeproduct.
    /// </summary>
    public static partial class ProductadoxiolicencesubcategorylicencefeeproductExtensions
    {
            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection Get(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(productid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection> GetAsync(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(productid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection> GetWithHttpMessages(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(productid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencesubcategory LicenceFeeProductByKey(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, string adoxioLicencesubcategoryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.LicenceFeeProductByKeyAsync(productid, adoxioLicencesubcategoryid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioLicencesubcategory> LicenceFeeProductByKeyAsync(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, string adoxioLicencesubcategoryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LicenceFeeProductByKeyWithHttpMessagesAsync(productid, adoxioLicencesubcategoryid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct from
            /// products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productid'>
            /// key: productid of product
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencesubcategory> LicenceFeeProductByKeyWithHttpMessages(this IProductadoxiolicencesubcategorylicencefeeproduct operations, string productid, string adoxioLicencesubcategoryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.LicenceFeeProductByKeyWithHttpMessagesAsync(productid, adoxioLicencesubcategoryid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
