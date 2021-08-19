/*
-- GENERATED BY NetCMS-Cli v0.1.0 BUILD 1200 -- 
Created on 7/21/2021 9:56:29 PM
Repos CLI: https://github.com/OpenCodeDev/OpenCodeDev.NetCMS.Compiler
License: MIT
Author: Max Samson
Company: OpenCodeDev
*/


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using OpenCodeDev.NetCMS.MyPlugin.Server.Api.Recipe.Models;

namespace OpenCodeDev.NetCMS.MyPlugin.Server.Database
{
    // Auto Generated DO NOT EDIT
    public class DatabaseBase : DbContext
    {
        public virtual DbSet<RecipeModel> Recipe { get; set; }

        public DatabaseBase(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Relation Code

            // Link Multiple Ingredients One-Way
            // Many To Zero (If Recipe is Link to Removed)
            // builder.Entity<RecipeModel>()
            // .HasMany(p => p.Ingredients)
            // .WithOne(p => (RecipeModel)p.Recipe)
            // .HasForeignKey(p => p.RecipeId)
            // .OnDelete(DeleteBehavior.Cascade);

            // // One to Zero (If Ingredient is Removed, Link is Removed)
            // builder.Entity<RecipeIngredientBinder>()
            // .HasOne(p => p.Ingredient)
            // .WithOne()
            // .HasForeignKey<RecipeIngredientBinder>(p => p.IngredientId).HasPrincipalKey<RecipeIngredientBinder>(p=>p.IngredientId)
            // .OnDelete(DeleteBehavior.Cascade);

            
    

        }

        /// <summary>
        /// Mock Up Test Data
        /// </summary>
        public void MockUp (){
            
        }
    }
}
