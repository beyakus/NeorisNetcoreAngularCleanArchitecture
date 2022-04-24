import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
/**
 * Observer listen changes of sidenav
 *
 * @export
 * @class StatusSidenavService
 */
@Injectable({
  providedIn: 'root',
})
export class StatusSidenavService {
  private status$ = new Subject();
  constructor() {}

  isOpen() {
    this.status$.next('');
  }

  status() {
    return this.status$.asObservable();
  }
}
