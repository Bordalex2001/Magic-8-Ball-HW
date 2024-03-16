using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball_HW
{
    internal class Presenter
    {
        public readonly IModel _model;
        public readonly IView _view;
        public Presenter() { }
        public Presenter(IView view)
        {
            _model = new Model();
            _view = view;
            _view.Ask += new EventHandler<EventArgs>(OnAskBtnClick);
        }
        private void OnAskBtnClick(object sender, EventArgs e)
        {
            string answer = _model.GetAnswer();
            _view.Answer = answer;
        }
    }
}