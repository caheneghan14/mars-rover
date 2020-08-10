import { Component, Inject, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  marsRoverPictures;
  isLoading: boolean = false;
  baseUrl: string;
  apiKey: string;
  @ViewChild('date', { static: false }) date: ElementRef


  constructor(private http: HttpClient,
    @Inject('BASE_URL') baseUrl_: string,
    @Inject('API_KEY') apiKey_: string) {
    this.baseUrl = baseUrl_;
    this.apiKey = apiKey_;
  }

  getPictures(event) {
    event.preventDefault();
    this.isLoading = true;
    this.http.get(this.baseUrl + `?apiKey=${this.apiKey}&date=${this.date.nativeElement.value}`).subscribe(result => {
      event.preventDefault();
      this.marsRoverPictures = result;
    }, error => console.error(error));
    return false;
  }

  stop() {
    return false;
  }
}
