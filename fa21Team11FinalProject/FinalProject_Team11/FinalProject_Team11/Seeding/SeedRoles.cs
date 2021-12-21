﻿using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

//TODO: Upddate this namespace to match your project name
namespace FinalProject_Team11.Seeding
{
    public class SeedRoles
    {
        public static async Task AddAllRoles(RoleManager<IdentityRole> roleManager)
        {
            //TODO: Add the needed roles - admin and customer are provided
            //as examples
            //if the admin role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Admin") == false)
            {
                //this code uses the role manager object to create the admin role
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            //if the customer role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Customer") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            //if the host role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Host") == false)
            {
                //this code uses the rolle manager object to create the host role
                await roleManager.CreateAsync(new IdentityRole("Host"));
            }

        }
    }
}
