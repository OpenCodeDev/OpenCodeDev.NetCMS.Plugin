/*
-- GENERATED BY NetCMS-Cli v0.1.0 BUILD 1200 -- 
Created on 7/21/2021 9:56:29 PM
Repos CLI: https://github.com/OpenCodeDev/OpenCodeDev.NetCMS.Compiler
License: MIT
Author: Max Samson
Company: OpenCodeDev
*/


using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//NetCMS Server Core System
using OpenCodeDev.NetCMS.Core.Server.Api;

//NetCMS Shared Core System
using OpenCodeDev.NetCMS.Core.Shared.Api.Messages;
using OpenCodeDev.NetCMS.Core.Shared.Extensions;

// Code Namespaces
using OpenCodeDev.NetCms.Shared.Api.Recipe.Models;
using OpenCodeDev.NetCms.Shared.Api.Recipe.Messages;

// Server Resources
using OpenCodeDev.NetCMS.MyPlugin.Server.Database;
using OpenCodeDev.NetCMS.MyPlugin.Server.Api.Recipe.Models;

namespace OpenCodeDev.NetCMS.MyPlugin.Server.Api.Recipe.Services
{

    // AUTO-GENERATE DO NOT EDIT

    /// <summary>
    /// This class is auto gen by NetCMS, it enables context specific core system... to reduce reflection use at runtime, we pre-generate at build time the core model.<br/>
    /// The function available should ALWAYS be available unless breaking update occure at the NetCMS-CLI and Core Level which you will have to responsability to check>br/>
    /// Note: your RecipeService will inherit this class any Core function can be overiden in your own way if a function if later remove it will be tag obselete several version prior and switch to throw Unimplemented as removal! if you override it you will be able to keep it running in the event of breaking update.
    /// </summary>
    internal class RecipeCoreService : ApiServiceBase
    {
      
        // public virtual IQueryable<RecipePublicModel> RecipeLoadReference(IQueryable<NAMESPACE_BASE_SHARED.Api.Recipe.Models.RecipePublicModel> model, RecipeReferences references){
        //     return model.Include(p => p.Ingredients);
        // }

        
        public virtual RecipeModel FilterUpdate(RecipeModel current, RecipeModel changed)
        {
            //_UPDATE_FILTER_BODY_
            return current;
        }

        public virtual RecipeModel FilterUpdateReferences(DatabaseBase db, RecipeModel current, RecipeUpdateOneRequest request)
        {
            // var _current = db.Recipe.Where(p => p.Id.Equals(current.Id)).First();

            // List Each Reference, See Behavior
            // db.Entry(_current).Collection(p => p.Ingredients).Load();
            // if (request.ReferenceBehavior.Ingredients == ReferenceEditBehavior.Process)
            // {
                
            // }
            return current;
        }

    }


}
 
