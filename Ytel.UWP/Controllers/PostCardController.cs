/*
 * Ytel.UWP
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;

namespace ytel.Controllers
{
    public partial class PostCardController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PostCardController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PostCardController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PostCardController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve a postcard object by its PostcardId.
        /// </summary>
        /// <param name="Models.ViewPostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewPostcard(Models.ViewPostcardInput input)
        {
            Task<string> t = ViewPostcardAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a postcard object by its PostcardId.
        /// </summary>
        /// <param name="Models.ViewPostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewPostcardAsync(Models.ViewPostcardInput input)
        {
            //validating required parameters
            if (null == input.Postcardid)
                throw new ArgumentNullException("postcardid", "The property \"Postcardid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Postcard/viewpostcard.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "postcardid", input.Postcardid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Create, print, and mail a postcard to an address. The postcard front must be supplied as a PDF, image, or an HTML string. The back can be a PDF, image, HTML string, or it can be automatically generated by supplying a custom message.
        /// </summary>
        /// <param name="Models.CreatePostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePostcard(Models.CreatePostcardInput input)
        {
            Task<string> t = CreatePostcardAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create, print, and mail a postcard to an address. The postcard front must be supplied as a PDF, image, or an HTML string. The back can be a PDF, image, HTML string, or it can be automatically generated by supplying a custom message.
        /// </summary>
        /// <param name="Models.CreatePostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePostcardAsync(Models.CreatePostcardInput input)
        {
            //validating required parameters
            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.From)
                throw new ArgumentNullException("mfrom", "The property \"From\" in the input object cannot be null.");

            if (null == input.Attachbyid)
                throw new ArgumentNullException("attachbyid", "The property \"Attachbyid\" in the input object cannot be null.");

            if (null == input.Front)
                throw new ArgumentNullException("front", "The property \"Front\" in the input object cannot be null.");

            if (null == input.Back)
                throw new ArgumentNullException("back", "The property \"Back\" in the input object cannot be null.");

            if (null == input.Message)
                throw new ArgumentNullException("message", "The property \"Message\" in the input object cannot be null.");

            if (null == input.Setting)
                throw new ArgumentNullException("setting", "The property \"Setting\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Postcard/createpostcard.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "to", input.To ),
                new KeyValuePair<string, object>( "from", input.From ),
                new KeyValuePair<string, object>( "attachbyid", input.Attachbyid ),
                new KeyValuePair<string, object>( "front", input.Front ),
                new KeyValuePair<string, object>( "back", input.Back ),
                new KeyValuePair<string, object>( "message", input.Message ),
                new KeyValuePair<string, object>( "setting", input.Setting ),
                new KeyValuePair<string, object>( "description", input.Description ),
                new KeyValuePair<string, object>( "htmldata", input.Htmldata )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of postcard objects. The postcards objects are sorted by creation date, with the most recently created postcards appearing first.
        /// </summary>
        /// <param name="Models.ListPostcardsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListPostcards(Models.ListPostcardsInput input)
        {
            Task<string> t = ListPostcardsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of postcard objects. The postcards objects are sorted by creation date, with the most recently created postcards appearing first.
        /// </summary>
        /// <param name="Models.ListPostcardsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListPostcardsAsync(Models.ListPostcardsInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Postcard/listpostcard.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "page", input.Page ),
                new KeyValuePair<string, object>( "pagesize", input.Pagesize ),
                new KeyValuePair<string, object>( "postcardid", input.Postcardid ),
                new KeyValuePair<string, object>( "dateCreated", input.DateCreated )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Remove a postcard object.
        /// </summary>
        /// <param name="Models.DeletePostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string DeletePostcard(Models.DeletePostcardInput input)
        {
            Task<string> t = DeletePostcardAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a postcard object.
        /// </summary>
        /// <param name="Models.DeletePostcardInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeletePostcardAsync(Models.DeletePostcardInput input)
        {
            //validating required parameters
            if (null == input.Postcardid)
                throw new ArgumentNullException("postcardid", "The property \"Postcardid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Postcard/deletepostcard.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "postcardid", input.Postcardid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 