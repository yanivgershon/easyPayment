import { Injectable } from '@angular/core';
import { User } from '../data/user';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  getUsers()
  {
    return [
       new User('tiv-taam','','054-45654654','אלנבי 141 תל אביב',null),
       new User('super yuda','','052-45754654','הרצל 17 ירושליים',null),
       new User('instelator','','054-45754654','הרצל 17 ירושליים',null),
       new User('plummer','','054-45354654','הרצל 17 ירושליים',null)
    ]
  }
  constructor() { }
}
