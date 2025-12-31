// Unit Tests for Scheduler
using NUnit.Framework;
using System;
based on namespace; using TaskSchedulerTool;
test class SchedulerTests 
tests here : 
since I'm system tests - A single test to check adding and executing tasks 
tests here : [TestFixture] 
tests here : [Test] public void Test_AddTask_ValidParameters()
tests here : [Test] public void Test_AddTask_EmptyTaskName()
tests here : Assert.Throws<ArgumentException>(() => scheduler.AddTask("", TimeSpan.FromSeconds(5))); tests here }
