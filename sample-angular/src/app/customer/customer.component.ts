import { Component, OnInit } from '@angular/core';
import { RepositoryService } from './../shared/services/repository.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  
  public firstName : string;
  public lastName : string;
  
  constructor(private repo: RepositoryService) { }

  ngOnInit() {
    this.getCustomer();
  }

  public getCustomer() {
      let apiAddress: string = "values";
      this.repo.getData(apiAddress)
        .subscribe(res => {
            this.firstName = res[0];
            this.lastName = res[1];
        });
  }
}