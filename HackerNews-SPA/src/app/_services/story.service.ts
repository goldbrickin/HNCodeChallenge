import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Story } from 'src/app/_models/story';

@Injectable({
  providedIn: 'root'
})
export class StoryService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getStories(): Observable<Story[]> {
    return this.http.get<Story[]>(this.baseUrl + 'GetNewStories');
  }
}
