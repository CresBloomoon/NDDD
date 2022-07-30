﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.WinForm.ViewModels;
using System;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);

            var measureMock = new Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatest()).Returns(entity);

            var vm = new LatestViewModel(measureMock.Object);

            //検索ボタンを押す
            vm.Search();

            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");

        }
    }
}