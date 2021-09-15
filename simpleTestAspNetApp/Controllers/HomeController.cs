using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simpleTestApplication.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace simpleTestApplication.Controllers
{
    public class HomeController : Controller
    {
        

        int[] OriginalNumbers = new int[7] { 7, 5, 3, 9, 6, 4, 1 };

        public IActionResult Index()
        {
            //Tarefa 1
            ViewBag.TaskOne = this.TaskOneManager();

            //Tarefa 2
            ViewBag.TaskTwo = this.TaskTwoManager();

            //Tarefa 3
            ViewBag.TaskThree = this.TaskThreeManager(new int[] { 2, 7, 11, 15 });
            
            return View();
        }

        private string TaskOneManager()
        {
            int[] numbers =  OriginalNumbers.ToArray();
            int sumOfValues;

            numbers = ArrayUtils.RemoveValue(ArrayUtils.ReplaceValue(numbers, 9, 5), 4);
            sumOfValues = ArrayUtils.AddArrayValues(numbers);

            return $"Lista original: [{String.Join(",", OriginalNumbers)}]. Nova lista: [{String.Join(",",numbers)}]. Soma dos valores da lista: {sumOfValues}";
        }
        private string TaskTwoManager()
        {
            return "O resultado da consulta será 85!";
        }
        private string TaskThreeManager(int[] values)
        {
            Dictionary<int, int[]> addedArrayValues;
            int firstNumber;
            int secondNumber;
            int total;

            addedArrayValues  = ArrayUtils.AddRandomArrayValues(values);
            firstNumber  = (int)addedArrayValues.First().Value.GetValue(0);
            secondNumber  = (int)addedArrayValues.First().Value.GetValue(1);
            total = (int)addedArrayValues.First().Key;

            return $"Lista de exemplo: [{String.Join(",", values)}], {firstNumber} + {secondNumber} resulta na soma de entrada: {total}! ";
        }
    }
}
