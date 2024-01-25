import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdituraListComponent } from './editura-list.component';

describe('EdituraListComponent', () => {
  let component: EdituraListComponent;
  let fixture: ComponentFixture<EdituraListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EdituraListComponent]
    });
    fixture = TestBed.createComponent(EdituraListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
