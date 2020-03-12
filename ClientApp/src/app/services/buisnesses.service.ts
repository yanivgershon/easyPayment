import { Injectable } from '@angular/core';
import { User } from '../data/user';

@Injectable({
  providedIn: 'root'
})
export class BuisnessesService {

  constructor() { }

  getBuisnesses()
  {
    return [
       new User('avi','',null,null,null),
       new User('eli','',null,null,null),
       new User('eti','',null,null,null),
       new User('aviv','',null,null,null)
    ]
  }
}
