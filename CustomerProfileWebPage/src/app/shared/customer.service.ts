import { Injectable } from '@angular/core';
import { Customer } from './customer.model';
import { HttpClient } from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class CustomerService {


  constructor(private http: HttpClient) { }

  readonly baseURL = 'http://localhost:40460/api/Customers'

  formData : Customer = new Customer();
  list: Customer[];

  postCustomerDetail() {
    return this.http.post(this.baseURL, this.formData);
  }

  putCustomerDetail() {
    return this.http.put(`${this.baseURL}/${this.formData.customerID}`, this.formData);
  }

  deleteCustomerDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res =>this.list = res as Customer[]);
  }

}
