import { Component, OnInit, Input } from '@angular/core';



@Component({
  selector: 'app-history-item',
  templateUrl: './history-item.component.html',
  styleUrls: ['./history-item.component.css']
})
export class HistoryItemComponent implements OnInit {

  @Input() historyData
  constructor() { }

  ngOnInit()
  {
    console.log('historyData',this.historyData)
  }

}
