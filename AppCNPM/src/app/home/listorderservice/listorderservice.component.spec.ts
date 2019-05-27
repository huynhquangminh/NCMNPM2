import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListorderserviceComponent } from './listorderservice.component';

describe('ListorderserviceComponent', () => {
  let component: ListorderserviceComponent;
  let fixture: ComponentFixture<ListorderserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListorderserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListorderserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
