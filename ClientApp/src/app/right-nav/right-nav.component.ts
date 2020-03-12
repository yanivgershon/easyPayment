import { Component, OnInit } from '@angular/core';
import { UsersService } from '../services/users.service';
import { BuisnessesService } from '../services/buisnesses.service';

@Component({
  selector: 'app-right-nav',
  templateUrl: './right-nav.component.html',
  styleUrls: ['./right-nav.component.css']
})
export class RightNavComponent implements OnInit {
usersData;
buissnessesData;
  constructor(private usersService:UsersService,
    private buissnessesService:BuisnessesService) { }

  ngOnInit() {
this.usersService.getUsers();
this.buissnessesService.getBuisnesses();
  }

}
