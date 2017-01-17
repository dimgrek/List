using System;
using System.Windows.Input;
using List.Models;
using MvvmCross.Core.ViewModels;

namespace List.ViewModels
{
    internal class AddTicketViewModel : MvxViewModel
    {
        private readonly EventHandler<PriorityEventArgs> priortiyChanged;
        private bool _isPriorityLow;

        private bool _isPriorityMedium;

        private bool _isPriorityTop;

        private string _problemName;

        private Priority _problemPriority;

        public AddTicketViewModel()
        {
            priortiyChanged += OnPriorityChanged;

            SetPriority(Priority.Top);
        }

        public ICommand TopCommand
        {
            get { return new MvxCommand(() => SetPriority(Priority.Top)); }
        }

        public ICommand MediumCommand
        {
            get { return new MvxCommand(() => SetPriority(Priority.Medium)); }
        }

        public ICommand LowCommand
        {
            get { return new MvxCommand(() => SetPriority(Priority.Low)); }
        }

        public ICommand SaveCommand
        {
            get { return new MvxCommand(Save); }
        }

        public string ProblemName
        {
            get { return _problemName; }
            set
            {
                _problemName = value;
                RaisePropertyChanged(() => ProblemName);
            }
        }

        public Priority ProblemPriority
        {
            get { return _problemPriority; }
            set
            {
                _problemPriority = value;
                RaisePropertyChanged(() => ProblemPriority);
            }
        }

        public bool IsPriorityLow
        {
            get { return _isPriorityLow; }
            set
            {
                _isPriorityLow = value;
                RaisePropertyChanged(() => IsPriorityLow);
            }
        }

        public bool IsPriorityMedium
        {
            get { return _isPriorityMedium; }
            set
            {
                _isPriorityMedium = value;
                RaisePropertyChanged(() => IsPriorityMedium);
            }
        }

        public bool IsPriorityTop
        {
            get { return _isPriorityTop; }
            set
            {
                _isPriorityTop = value;
                RaisePropertyChanged(() => IsPriorityTop);
            }
        }

        private void Save()
        {
            var ticket = new Ticket
            {
                Priority = ProblemPriority,
                ProblemName = ProblemName
            };
            //working with DB:
            //db.Add(ticket);
        }

        private void OnPriorityChanged(object sender, PriorityEventArgs args)
        {
            var priority = args.Priority;
            IsPriorityTop = false;
            IsPriorityLow = false;
            IsPriorityMedium = false;
            switch (priority)
            {
                case Priority.Top:
                    IsPriorityTop = true;
                    break;
                case Priority.Medium:
                    IsPriorityMedium = true;
                    break;
                case Priority.Low:
                    IsPriorityLow = true;
                    break;
                default:
                    break;
            }
        }


        private void SetPriority(Priority priority)
        {
            ProblemPriority = priority;
            priortiyChanged.Invoke(null, new PriorityEventArgs(ProblemPriority));
        }
    }

    internal class PriorityEventArgs : EventArgs
    {
        public PriorityEventArgs(Priority priority)
        {
            Priority = priority;
        }

        public Priority Priority { get; }
    }
}