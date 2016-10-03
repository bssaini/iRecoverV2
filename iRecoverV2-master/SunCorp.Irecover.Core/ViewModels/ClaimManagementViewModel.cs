﻿using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SunCorp.IRecover.ViewModels
{
    public class ClaimManagementViewModel : BaseViewModel
    {
        private ICommand mGotoNewClaimCommand;
        private ICommand mGotoClaimHistoryCommand;
        private ICommand mSpeakToARepresentativeCommand;
        private Action mSpeakToARepresentativeAction;

        public ICommand GotoNewClaimCommand
        {
            get
            {
                mGotoNewClaimCommand = mGotoNewClaimCommand ?? new MvxCommand(GoToNewClaimAction);
                return mGotoNewClaimCommand;
            }
        }

        public ICommand GotoClaimHistoryCommand
        {
            get
            {
                mGotoClaimHistoryCommand = mGotoClaimHistoryCommand ?? new MvxCommand(GotoClaimHistoryAction);
                return mGotoClaimHistoryCommand;
            }
        }
        
        public ICommand SpeakToARepresentativeCommand
        {
            get
            {
                mSpeakToARepresentativeCommand = mSpeakToARepresentativeCommand ?? new MvxCommand(SpeakToARepresentativeAction);
                return mSpeakToARepresentativeCommand;
            }
        }

        public void SetOnSpeakToARepresentativeAction(Action speakToARepresentativeAction)
        {
            mSpeakToARepresentativeAction = speakToARepresentativeAction;
        }

        #region private methods
        private void GoToNewClaimAction()
        {
            ShowViewModel<NewClaimViewModel>();
        }

        private void SpeakToARepresentativeAction()
        {
            if (mSpeakToARepresentativeAction == null)
            {
                throw new Exception($"The activity must implement{mSpeakToARepresentativeAction}");

            }
            mSpeakToARepresentativeAction();

        }

        private void GotoClaimHistoryAction()
        {
            ShowViewModel<ClaimHistoryViewModel>();
        }
        #endregion
    }
}