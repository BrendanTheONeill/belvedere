using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BelvedereServices.Models;

namespace BelvedereServices.Pages
{
    public class ServiceModel : PageModel
    {
        public List<ServicesModel> fakeServiceDB = new List<ServicesModel>()
        {
            new ServicesModel(){
                ImageTitle="Grass Cutting", ServiceName="GrassCutting",
                BasePrice=100,
                GrassCutting=true,
                FinalPrice=400},

            new ServicesModel(){
                ImageTitle="Landscaping", ServiceName="Landscaping",
                BasePrice=100,
                TreePlanting=true, GrassCutting=true,
                FinalPrice=800},

            new ServicesModel(){
                ImageTitle="Cleanup", ServiceName="Cleanup",
                BasePrice=100,
                GrassCutting=true, RoofCleaning=true,
                FinalPrice=700},

            new ServicesModel(){
                ImageTitle="Abandoned Cleanup", ServiceName="AbandonedCleanup",
                BasePrice=100,
                GrassCutting=true, RoofCleaning=true, Powerwashing=true, ClutterRemoval=true,
                FinalPrice=1500},

            new ServicesModel(){
                ImageTitle="Remodeling", ServiceName="Remodeling",
                BasePrice=100,
                HousePainting=true, PoolInstallation=true,
                FinalPrice=1000},

            new ServicesModel(){
                ImageTitle="Seasonal Cleaning", ServiceName="SeasonalCleaning",
                BasePrice=100,
                GrassCutting=true, RoofCleaning=true, TreePlanting=true, ClutterRemoval=true,
                FinalPrice=1500},

            new ServicesModel(){
                ImageTitle="Problem Solving", ServiceName="ProblemSolving",
                BasePrice=100,
                ProblemSolving=true,
                FinalPrice=3100},
        };
        public void OnGet()
        {
        }
    }
}
