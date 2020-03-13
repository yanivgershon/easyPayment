import { Injectable } from '@angular/core';
import { HistoryData } from '../data/history';
import { UsersService } from './users.service';
import { BuisnessesService } from './buisnesses.service';

@Injectable({
  providedIn: 'root'
})
export class HistoryService {

  constructor(private usersService:UsersService,
    private buisnessesServive:BuisnessesService)
    {

  }
  getHistory()
  {
    var users=this.usersService.getUsers();
    var buisnesses=this.buisnessesServive.getBuisnesses();
    var history=[
      new HistoryData("1/3/2017",300,1,1,users[0]),
      new HistoryData("13/3/2017",300,1,2,users[1]),
      new HistoryData("2/3/2017",300,1,3,users[2]),
    ]
    return history;

  }

}
