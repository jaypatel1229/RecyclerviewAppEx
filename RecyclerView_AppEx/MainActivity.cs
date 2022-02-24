using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;

namespace RecyclerView_AppEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private RecyclerView _employeeRecyclerView;
        
        private List<string> _employeeName;
        private EmployeeAdapter _employeeAdapter;
        RecyclerView.LayoutManager _layoutManager;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _employeeRecyclerView = FindViewById<RecyclerView>(Resource.Id._albumRecyclerView);
          


            GenerateDummyRecord();



            _layoutManager = new LinearLayoutManager(this);
            _employeeRecyclerView.SetLayoutManager(_layoutManager);

            _employeeAdapter = new EmployeeAdapter(_employeeName);
            _employeeRecyclerView.SetAdapter(_employeeAdapter);
            _employeeAdapter.ItemClick += _employeeAdapter_ItemClick;

        }

        private void _employeeAdapter_ItemClick(object sender, int e)
        {
            Toast.MakeText(this, "Hi " + _employeeName[e].ToString(), ToastLength.Short).Show();
        }


        private void GenerateDummyRecord()

        {
            _employeeName = new List<string>();


            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Ross");
            _employeeName.Add("Rachel");
            _employeeName.Add("Monica");
            _employeeName.Add("Joey");
            _employeeName.Add("Chandler");
            _employeeName.Add("Chandler");
            _employeeName.Add("Chandler");
            _employeeName.Add("Chandler");





        }



    }
}