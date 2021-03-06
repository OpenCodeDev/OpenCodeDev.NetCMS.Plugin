/*
-- GENERATED BY NetCMS-Cli v0.1.0 BUILD 1200 -- 
Created on 7/21/2021 9:56:29 PM
Repos CLI: https://github.com/OpenCodeDev/OpenCodeDev.NetCMS.Compiler
License: MIT
Author: Max Samson
Company: OpenCodeDev
*/


using Grpc.Core;
using ProtoBuf.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Code Namespaces
using OpenCodeDev.NetCms.Shared.Api.Recipe.Models;
using OpenCodeDev.NetCms.Shared.Api.Recipe.Messages;
using OpenCodeDev.NetCms.Shared.Api.Recipe.Controllers;

// DO NOT EDIT, REGENERATED AT EACH BUILD.

namespace OpenCodeDev.NetCMS.MyPlugin.Server.Api.Recipe.Controllers
{
    /// <summary>
    /// Provides with Api Controller's wrapper mainly for permission, authentication and other operation required to process request. <br/>
    /// If you use a custom endpoint, you will have to see the official documentation to call permission and auth functions
    /// </summary>
    public partial class RecipeControllerEndpoints : IRecipeController
    {
        public virtual async Task<RecipePublicModel> Create(RecipeCreateRequest request, CallContext context = default)
        {
            // Check for Permissions, Check for Field Permission
            // Check for ApiKey Permission, Check for Account Role Permissions
            // Check for Form Validation
            // If everything checks out, call the real thing.
            try
            {
                var api = new RecipeController();
                return await api.Create(request, context);
            }
            catch (RpcException ex)
            {
                throw new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
            }
            catch (NullReferenceException ex)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
            }
            catch (Exception ex)
            {
                //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                // error is related to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user.
                Console.WriteLine(ex.Message);
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
            }
        }

        public virtual async Task<RecipePublicModel> Delete(RecipeDeleteRequest request, CallContext context = default)
        {
            try
            {
                var api = new RecipeController();
                return await api.Delete(request, context);
            }
            catch (RpcException ex)
            {
                throw new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
            }
            catch (NullReferenceException ex)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
            }
            catch (Exception ex)
            {
                //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                // error is relayed to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user from the plugin in question.
                Console.WriteLine(ex.Message);
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
            }
        }

        public virtual async Task<List<RecipePublicModel>> Fetch(RecipeFetchRequest request, CallContext context = default)
        {
            try
            {
                var api = new RecipeController();
                return await api.Fetch(request, context);
            }
            catch (RpcException ex)
            {
                throw new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
            }
            catch (NullReferenceException ex)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
            }
            catch (Exception ex)
            {
                //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                // error is related to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user.
                Console.WriteLine(ex.Message);
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
            }
        }

        public virtual async Task<RecipePublicModel> FetchOne(RecipeFetchOneRequest request, CallContext context = default)
        {
            try
            {
                var api = new RecipeController();
                return await api.FetchOne(request, context);
            }
            catch (RpcException ex)
            {
                throw new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
            }
            catch (NullReferenceException ex)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
            }
            catch (Exception ex)
            {
                //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                // error is related to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user.
                Console.WriteLine(ex.Message);
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
            }
        }

        public virtual async Task<RecipePublicModel> Update(RecipeUpdateOneRequest request, CallContext context = default)
        {
            try
            {
                var api = new RecipeController();
                return await api.Update(request, context);
            }
            catch (RpcException ex)
            {
                throw new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
            }
            catch (NullReferenceException ex)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
            }
            catch (Exception ex)
            {
                //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                // error is related to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user.
                Console.WriteLine(ex.Message);
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
            }
        }

        public virtual async Task<List<RecipeUpdateManyResponse>> UpdateMany(RecipeUpdateManyRequest request, CallContext context = default)
        {
            var api = new RecipeController();
            List<RecipeUpdateManyResponse> list = new List<RecipeUpdateManyResponse>();
            foreach (var item in request.BulkUpdate)
            {
                var resultResponse = new RecipeUpdateManyResponse();
                try
                {
                    var result = await Update(item, context);
                    resultResponse.Entry = result;
                }
                catch (RpcException ex)
                {
                    resultResponse.Error = new RpcException(new Status(ex.Status.StatusCode, ex.Status.Detail));
                    resultResponse.HasError = true;
                }
                catch (NullReferenceException ex)
                {
                    resultResponse.Error = new RpcException(new Status(StatusCode.NotFound, "Entry was not found."));
                    resultResponse.HasError = true;
                }
                catch (Exception ex)
                {
                    //TODO: IDEA ?  Create a grpc error handler at core base, whenever error is thrown during request,
                    // error is related to the core system and every plugin register all error handling with messages then core return grpc error to throw.
                    // Example: Stripe would register StripeException, so whenever a plugin uses stripe and throw that error, catch this to print a more accurate msg for user.
                    resultResponse.Error = new RpcException(new Status(StatusCode.Unknown, "Unknown error occured"));
                    resultResponse.HasError = true;
                }

            }
            return list;
        }
    }
}
 
