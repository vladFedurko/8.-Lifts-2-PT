﻿using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class CreateHumanPresenter
    {
        private ICreateHumanView _view;
        private IHumanCreationService _humanService;

        public CreateHumanPresenter(ICreateHumanView view, IHumanCreationService service)
        {
            this._view = view;
            this._humanService = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.CreateHuman += this.CreateHuman;
        }

        public void CreateHuman(int humanNumber,int initialFloor, int finiteFloor, int inSeconds)
        {
            _humanService.CreateHuman(humanNumber,initialFloor - 1, finiteFloor - 1, inSeconds); //отсчет с 0
        }
    }
}
